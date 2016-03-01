var express = require('express');
var app = express();
var mongoose = require('mongoose');
var morgan = require('morgan'); // log requests to the console (express4)
var bodyParser = require('body-parser'); // pull information from HTML POSt
var methodOverride = require('method-override'); // simulate DELETE and PUT (express4)
app.use(bodyParser());
app.use(express.static(__dirname+'/client'));

var port = process.env.PORT || 8081;

var database = require('./server/controllers/database')(app);

mongoose.connection.on("connected", function (result) {
    console.log("the database has been connected")
});

mongoose.connection.on("error", function (err) {
    console.log("connection error", err);
});

app.listen(port, function (err,result) {
    if(!err)
    console.log("The app is working fine");
});

require('./server/routes/route.js')(app);
module.exports=app;
