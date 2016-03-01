var User=require('../models/user');
var crypto=require('crypto');
var morgan = require('morgan');
var nodeMailer=require('nodemailer');
var config=require('../models/config');
var register=function(req,res){
    console.log("the re#############",req.body);
    var resjson={};
    resjson.success="false";
    var email=req.body.email;
    User.create(req.body,function(err,added){
    if(!err){
         config.findOne({"configtype":"mailcredentials"},function(err,mailData){

       var activationLink="http://" + req.host + ":8081/Account/Activate.aspx?code=" + encryption(email) + "&email=" + email;
    var transporter = nodeMailer.createTransport({
                service: 'Gmail',
                //uncomment tls to test in local machine.
                tls: {
                        rejectUnauthorized: false
                    },
                auth: {
                user: mailData.username,
                pass: mailData.password
                }
                });
    var mailOptions = {
    from: mailData.username, // sender address
    to: email,
    subject: 'Click Link To Activate', // Subject line
    /*text:  // plaintext body*/
    html: activationLink // html body
};
        transporter.sendMail(mailOptions,function(err,info){
        if(!err)
            resjson.success="true";
        res.send(resjson);

        });
    });

    }
        else{
            console.log("error is",err);
            res.send(resjson);
        }
    });

};

var encryption=function(email){
return crypto.createHash('md5').update(email).digest('hex');
};

module.exports ={ register:register};
