var mongoose=require('mongoose');
var product=mongoose.model("product",{
    "name":String,
    "number":Number,
    "category":String,
    "price":String,
    "warranty":Number,
    "description":String

});

module.exports=product;
