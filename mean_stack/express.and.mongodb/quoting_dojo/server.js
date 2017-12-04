var express = require('express');
var app = express();
var mongoose = require('mongoose');


mongoose.connect('mongodb://localhost/quotes');
mongoose.Promise = global.Promise;

var QuoteSchema = new mongoose.Schema({
    name: String,
    data: String
   })
   mongoose.model('Quote', QuoteSchema); // We are setting this Schema in our Models as 'User'
   var Quote = mongoose.model('Quote') // We are retrieving this Schema from our Models, named 'User'   

var bodyParser = require('body-parser');
app.use(bodyParser.urlencoded({ extended: true }));
var path = require('path');
app.use(express.static(path.join(__dirname, './static')));
app.set('views', path.join(__dirname, './views'));
app.set('view engine', 'ejs');
app.get('/', function(req, res){
    
     res.render('index');
 })
app.post('/add_quote', function(req, res) {
    console.log("POST DATA", req.body);
    // create a new User with the name and age corresponding to those from req.body
    var quote = new Quote({name: req.body.name, data: req.body.data});
    // Try to save that new user to the database (this is the method that actually inserts into the db) and run a callback function with an error (if any) from the operation.
    quote.save(function(err) {
      // if there is an error console.log that something went wrong!
      if(err) {
        console.log('something went wrong');
      } else { // else console.log that we did well and then redirect to the root route
        console.log('successfully added a quote!');
        res.redirect('/quotes');
      }
    })
  })
app.get('/quotes', function(req, res){
    Quote.find({}, function(errors, dbQuote) {
      console.log("in /")
      console.log(dbQuote)
      res.render('quotes', {quote: dbQuote});      
    })   
 })
app.listen(8000, function () {
    console.log("listening on port 8000");
})
