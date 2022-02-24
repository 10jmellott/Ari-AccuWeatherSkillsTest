<template>
<div>
	<!-- <button @click="increment(1)">Increment</button>
	<span>count is {{ count }}</span> -->
	<location-search></location-search>
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
			increment(amount) {
				this.count += amount;
				return axios.get('/hello');
			},
		},
	}
</script>
<style>

</style>
