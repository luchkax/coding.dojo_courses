var users = require('../controllers/users.js');

module.exports = function(app){

    app.get('/', function(req,res){
        res.render('index');
    });
    
    app.post('/register', function(req,res){
        users.add(req,res);
    });
    
    app.post('/login', function(req,res){
        users.show(req,res);
    });

    app.get('/user', function (req, res){ 
        res.render('user');
    });
    
}