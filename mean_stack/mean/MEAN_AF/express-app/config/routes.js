var mongoose = require('mongoose');
var task = require('../controllers/task_controller.js');
var path = require('path');

console.log("Yo this is routes.js")

module.exports = function(app){

app.get('/api', function(req, res){
    task.index(req, res)
});

app.get('/api/tasks', function(req, res){
    task.index(req, res)
});

app.post('/api/tasks', function(req, res){
    task.create(req, res) 
});

app.all("*", (req,res,next) => {
    res.sendFile(path.resolve("./angular-app/dist/index.html"))
  });


}