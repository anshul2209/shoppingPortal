var mongoose=require('mongoose');

var configs=mongoose.model('config',{
    "configtype":String,
    "username":String,
    "password":String
});

module.exports=configs;
