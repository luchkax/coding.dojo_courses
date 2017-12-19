var mongoose = require('mongoose');
var User = mongoose.model('User')


module.exports = {

    add: function (req, res) {
        console.log("POST DATA", req.body);
        var user = new User({ 
            first_name: req.body.first_name, 
            last_name: req.body.last_name, 
            email: req.body.email, 
            password: req.body.password, 
            bdate: req.body.bdate
        });
        console.log(user.id)
        user.save(function (err) {
        if (err) {
            console.log(err);
            res.redirect('/user')
            
        } else {
            console.log('successfully added user!');
    
            res.redirect('/')
        }
        })
    },

    show: function (req, res) {
        User.findOne({ email: req.body.email, password: req.body.password }, function (err, user) {
            if (user) {
                // req.session[first_name] = user.first_name
                console.log('loged in!')
            }
            else {
                console.log("NO");
            }
        console.log("innnnnn /")
        res.redirect ('/user');
        })
    },

   

}