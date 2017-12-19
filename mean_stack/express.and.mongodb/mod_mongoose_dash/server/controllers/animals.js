var mongoose = require('mongoose');
var Animal = mongoose.model('Animal')


module.exports = {
    index: function (req, res) {
        Animal.find({}, function (errors, dbAnimal) {
        console.log("in /")
        console.log(dbAnimal)
        res.render('index', { animals: dbAnimal });
        })
    },

    add: function (req, res) {
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
    },

    show_animal: function (req, res) {
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
    },
    edit: function (req, res) {
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
    },

    edit_post: function (req, res) {  
        Animal.update({ _id: req.params.id }, req.body, function (err, animal) {
        console.log(animal)
        if (err) { console.log("Error occured"); }
        res.redirect('/');
        }
    )},
    
    delete: function (req, res) {
        Animal.remove({ _id: req.params.id }, function (err, deleteAnimal) {
        console.log(deleteAnimal)
        if (err) { console.log("Error occured"); }
        res.redirect('/');
        });
    },
}