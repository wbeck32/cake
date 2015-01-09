#!/usr/bin/env node

//cake.js
var oven = require('./oven');
var cakeInProgress;

//init
//to init this program, prompt the user to enter their parameters

mix = function(arr) {
	console.log("You are mixing: ");
	arr.forEach(function(v,i) {
		console.log(arr[i]);
	});
	return arr;
};

pour = function(container,pourable) {
	cakeInProgress = {
		container: container,
		contents: pourable,
		finishedProduct: 'cake'
	};
	console.log('You are pouring '+cakeInProgress.contents+' into the '+cakeInProgress.container);
	return cakeInProgress;
};
decorate = function(cake,frosting) {
	console.log('Now you are decorating the '+cake+' with '+frosting+'.'+);
};

oven.preheat(350);

// make the cake batter
var batter = mix(['flour', 'eggs', 'butter']);
var pan = {
  type: 'pan',
  diameter: '9in',
  shape: 'round'
};

var cake = pour("pan", "batter");

// bake the cake
oven.addItem(cakeInProgress.container);
oven.setTimer(function(){
	oven.removeItem(cakeInProgress.finishedProduct);
	decorate(cakeInProgress.finishedProduct,"frosting");	
}, 10,'seconds');
var frosting = mix(['sugar', 'butter']);


