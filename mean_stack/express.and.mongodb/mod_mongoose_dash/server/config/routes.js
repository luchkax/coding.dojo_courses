var animals = require('../controllers/animals.js');

module.exports = function(app){

    app.get('/', function(req,res){
        animals.index(req,res);
    });
    
    app.post('/add_animal', function(req,res){
        animals.add(req,res);
    });
    
    app.get('/animal/id:id', function(req,res){
        animals.show_animal(req,res);
    });
    
    
    app.get('/animal/new', function (req, res){ 
        res.render('new');
    });
    
    app.get('/animal/id:id/edit', function(req,res){
        animals.edit(req,res);
    });
    
    app.post('/edit_animal/:id', function(req,res){
        animals.edit_post(req,res);
    });
    
    app.post('/delete_animal/:id', function(req,res){
        animals.delete(req,res);
    });
}