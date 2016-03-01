var mongoose=require('mongoose');
var user=mongoose.model('User',{
    'name':String,
    'email':String,
    'phone':Number,
    'role':String,
    'customerid':String,
    'address':{
        "address1":String,
        "address2":String,
        "city":String,
        "state":String,
        "pincode":Number
    },
    'password':String,
    'activationcode':String

});

module.exports=user;
