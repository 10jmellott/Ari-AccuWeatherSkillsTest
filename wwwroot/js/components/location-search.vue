<template>
<div class="location-search-container">
	<div class="location-search-box">
		<svg data-qa="searchIcon" xmlns="http://www.w3.org/2000/svg" class="search-icon" width="16" height="16" viewBox="0 0 16 16"><path d="M15.784 13.68l-4.096-4.096c.585-.955.94-2.067.94-3.27a6.315 6.315 0 1 0-6.314 6.314 6.253 6.253 0 0 0 3.27-.937l4.096 4.094a.751.751 0 0 0 1.052 0l1.052-1.052a.75.75 0 0 0 0-1.053zm-9.47-3.157a4.21 4.21 0 1 1 0-8.419 4.21 4.21 0 0 1 0 8.42z"></path></svg>
		<input type="text" class="search_input" @input="searchLocation" v-model="search_key" placeholder="Search Location...">
	</div>
	<ul v-show="!selected_location && location_options.length > 0 && search_key.length > 0" class="location-list">
		<li v-for="location in location_options" :key="location.key" @click="selectLocation(location)">
			{{location.displayName}}
		</li>
	</ul>
</div>
</template>
<script>
import axios from "axios";
	export default {
		name:'location-search',
		data() {
			return {
				count: 0,
				search_key: '',
				selected_location: null,
				location_options: []
			}
		},
		methods: {
			searchLocation() {
				if(this.search_key.length > 0) {
					return axios.get('/searchlocation?key='+this.search_key).then((response) => {
						this.selected_location = null;
						this.location_options = response.data.slice(0,5);
					});
				}
			},
			selectLocation(location) {
				this.search_key = '';
				this.selected_location = location;
				this.setCookie('location', location.key);
				window.location.reload(); //far from "graceful" but it's one way to update C# viewcomponents
			},
			getCookies() {//gets cookies and formats them into an object so we can access it like a hashmap
				return document.cookie.length > 0 ? document.cookie.split(';').reduce((cookies_list, cookie) => {
					let [key,value] = cookie.split('=');
					if(!!key) {
						cookies_list[key] = value;
					}
					return cookies_list;
				}, {}) : {};
			},
			setCookie(name, value) {
				let cookie_max_age = 30 * 24 * 60 * 60 * 1000; //setting max age to be 30 days
				document.cookie= name + '=' + value + ';max-age=' + cookie_max_age + ';path=/';
			}
		},
	}
</script>
<style scoped>
.location-search-container {
	width: 30%;
	margin: auto;
	border-radius: 5px;
	font-size: 1.2rem;
	font-weight: bold;
	display: flex;
	flex-flow: column;
}
.location-search-box {
	border: solid 1px #cfcfcf;
	width:100%;
	padding: 10px;
	border-radius: 5px;
	font-size: 1.2rem;
	font-weight: bold;
	display: flex;
}
.search_input {
	width: 80%;
	margin-left:1rem;
}
.location-list {
	padding: 0 5%;
	border: solid 1px #cfcfcf;
	border-top: none;
	list-style: none;
	display: flex;
	flex-flow: column;
}
.location-list li {
	cursor: pointer;
	line-height:1;
}
.location-list li:hover {
	background-color: #dfdfdf;
}
.search-icon {
	width:30px;
	height:30px;
	fill: #1e1e1e;
	opacity: .6;
}
@media (max-width: 320px) {
	.location-search-container {
		width: 80%;
	}
	.search-icon {
		width:20px;
		height:20px;
	}
}
</style>
