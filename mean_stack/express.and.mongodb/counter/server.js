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
app.use(express.static(path.resolve('assets')));
app.use(session(sessionConfig));

app.get('/', function(req, res){
    var counter;
    if(!req.session.counter) {
        req.session.counter = 1;
        counter = req.session.counter;
    }
    else{
        req.session.counter += 1;
        counter = req.session.counter;
    }
    res.render('index', {count_key : counter}); //can pass through an object
    console.log(req.session.counter);
});

app.post('/by-two', function(req, res){
    req.session.counter += 1;
    counter = req.session.counter;
    res.redirect('/');
})

app.post('/reset', function(req, res){
    req.session.destroy();
    res.redirect('/');
})


app.listen(8000, function () {
    console.log("listening on port 8000");
})

