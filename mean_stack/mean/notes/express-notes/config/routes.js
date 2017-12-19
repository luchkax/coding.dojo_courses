var mongoose = require('mongoose');
var note = require('../controllers/notes_controller.js');
var path = require('path');

console.log("Yo this is routes.js")

module.exports = function(app){

app.get('/api', function(req, res){
    note.index(req, res)
});

app.get('/api/notes', function(req, res){
    note.index(req, res)
});

// app.post('/api/tasks', function(req, res){
//     task.create(req, res) 
// });

app.all("*", (req,res,next) => {
    res.sendFile(path.resolve("./angular-notes/dist/index.html"))
  });


}