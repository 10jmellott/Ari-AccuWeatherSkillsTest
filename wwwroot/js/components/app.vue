<template>
<div>
	<location-search></location-search>
	<button @click="testAPI('alerts')">GET ALERTS</button>
	<button @click="testAPI('hourlyforecast')">GET HOURLY</button>
	<button @click="testAPI('dailyforecast')">GET DAILY</button>
</div>
</template>
<script>
import axios from 'axios';
import locationSearch from './location-search.vue';
	export default {
		components:{locationSearch},
		data() {
			return {
				count: 0,
			}
		},
		methods: {
			getCookies() {//gets cookies and formats them into an object so we can access it like a hashmap
				return document.cookie.length > 0 ? document.cookie.split(';').reduce((cookies_list, cookie) => {
					let [key,value] = cookie.split('=');
					if(!!key) {
						cookies_list[key] = value;
					}
					return cookies_list;
				}, {}) : {};
			},
			testAPI(path) {
				let key = this.getCookies().location;
				console.log('/' + path + '?key='+ key);
				return axios.get('/' + path + '?key='+ key).then((response) => {
					console.log(response);
				});
			}
		},
	}
</script>
<style>

</style>
