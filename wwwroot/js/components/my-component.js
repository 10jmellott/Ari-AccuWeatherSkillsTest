// my-component.js
export default {
	data() {
		return {
			count: 0
		}
	},
	methods: {
		increment(amount) {
			this.count += amount;
		}
	},
	template: `
		<div>
			<button v-on:click="increment(1)">Increment</button>
			<span>count is {{ count }}</span>
		</div>
	`
}
