var registerController=require('../controllers/register');
var routes=function(app){
app.post("/registerme",registerController.register);
app.get('*', function (req, res) {
		res.sendFile('index.html',{root:'./'});
	});
};

module.exports=routes;
