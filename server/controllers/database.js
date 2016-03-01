var mongoose=require('mongoose');
var url="localhost/eshoppedb";


function connection(app){

    var env=app.get('env');
    mongoose.connect(url);

}
module.exports=connection;
