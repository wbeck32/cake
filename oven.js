#!/usr/bin/env node
//oven.js

module.exports = {
	preheat: function(temp) {
		console.log("You are preheating the oven to "+temp+" degrees.");
	},
	addItem: function(item) {
		console.log("You are putting the "+item+" in the oven.");
	},
	removeItem: function(item) {
		console.log("You are removing the "+item+'.');
	
	},
	setTimer: function(fn,time,units) {
		console.log('Now you are setting the timer for '+time+' '+units+'.');
		var timeToMs;
		switch (units) {
			case 'milliseconds':
				timeToMs = time;
				break;
			case 'seconds':
				timeToMs = time * 1000;
				break;
			case "minutes":
				timeToMs = (time / 60) * 1000;
				break;
			case "hours":
				timeToMs = (time / 3600) * 1000;
				break;
			default:
				console.log('that is not a valid unit');
				//break;		
	};
		setTimeout(fn,timeToMs);
}
};