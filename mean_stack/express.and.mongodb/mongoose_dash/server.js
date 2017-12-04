var express = require('express');
var app = express();
var mongoose = require('mongoose');


mongoose.connect('mongodb://localhost/mongooses');
mongoose.Promise = global.Promise;

var AnimalSchema = new mongoose.Schema({
  name: String,
  height: Number,
  food: String
})
mongoose.model('Animal', AnimalSchema); // We are setting this Schema in our Models as 'User'
var Animal = mongoose.model('Animal') // We are retrieving this Schema from our Models, named 'User'   

var bodyParser = require('body-parser');
app.use(bodyParser.urlencoded({ extended: true }));
var path = require('path');
app.use(express.static(path.join(__dirname, './static')));
app.set('views', path.join(__dirname, './views'));
app.set('view engine', 'ejs');


app.get('/', function (req, res) {
  Animal.find({}, function (errors, dbAnimal) {
    console.log("in /")
    console.log(dbAnimal)
    res.render('index', { animals: dbAnimal });
  })
})

app.post('/add_animal', function (req, res) {

  console.log("POST DATA", req.body);
  var animal = new Animal({ name: req.body.name, height: req.body.height, food: req.body.food });
  animal.save(function (err) {

    if (err) {
      console.log('something went wrong');
    } else {
      console.log('successfully added an animal!');

      res.redirect('/');
    }
  })
});

app.get('/animal/id:id', function (req, res) {
  Animal.findOne({ _id: req.params.id }, function (err, dbAnimal) {
    console.log("innnnnn /")
    console.log(dbAnimal)
    if (err) {
      console.log('something went wrong');
    } else {
      console.log('successfully showed an animal!');
    }
    res.render('animal', { animal: dbAnimal });
  })

});


app.get('/animal/new', function (req, res) {

  res.render('new');
})


app.get('/animal/id:id/edit', function (req, res) {
  Animal.findOne({ _id: req.params.id }, function (err, editAnimal) {
    console.log("innnnnn /")
    console.log(editAnimal)
    if (err) {
      console.log('something went wrong');
    } else {
      console.log('successfully showed an animal!');
    }
    res.render('edit', { animal: editAnimal });
  })
});

app.post('/edit_animal/:id', function (req, res) {

  Animal.update({ _id: req.params.id }, req.body, function (err, animal) {
    console.log(animal)
    if (err) { console.log("Error occured"); }
    res.redirect('/');
  });
});

app.post('/delete_animal/:id', function (req, res) {

  Animal.remove({ _id: req.params.id }, function (err, deleteAnimal) {
    console.log(deleteAnimal)
    if (err) { console.log("Error occured"); }
    res.redirect('/');
  });
});


app.listen(8000, function () {
  console.log("listening on port 8000")
});