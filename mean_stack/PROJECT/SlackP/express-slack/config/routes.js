var mongoose = require('mongoose');
var note = require('../controllers/user_controller.js');
var path = require('path');

console.log("Yo this is routes.js")

module.exports = function(app){

app.get('/api', function(req, res){
    note.index(req, res)
});


app.all("*", (req,res,next) => {
    res.sendFile(path.resolve("./angular-slack/dist/index.html"))
  });
}