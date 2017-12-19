var mongoose = require('mongoose');

var AnimalSchema = new mongoose.Schema({
    name: String,
    height: Number,
    food: String
  })

  var Animal = mongoose.model('Animal', AnimalSchema);