const session = require('express-session');
const bodyParser = require('body-parser');
const express = require('express');
const path = require('path');
const port = process.env.PORT || 8000;
const app = express();

const sessionConfig = {
    saveUninitialized: true,
    resave: false,
    name: 'session',
    secret: 'thisIsSuperSekret'
};

app.set('view engine', 'ejs');
app.set('views', path.resolve('views'));

app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static(path.resolve('styles')));
app.use(session(sessionConfig));

app.get('/', function(req, res){
   
    res.render('index');
})

app.get('/result', function(req,res){
    var info = {
        'name': req.session.name,
        'location': req.session.location,
        'language': req.session.language,
        'comment': req.session.comment,
    };
    res.render('result',info);
})

app.post('/fsubmit', function(req,res) {
    console.log("Post data info"); 
    req.session.name = req.body.name;
    req.session.location = req.body.location;
    req.session.language = req.body.language;
    req.session.comment = req.body.comment;
        
    res.redirect('/result')
})

app.listen(8000, function () {
    console.log("listening on port 8000");
})