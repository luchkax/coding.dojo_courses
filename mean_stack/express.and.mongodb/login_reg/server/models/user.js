var mongoose = require('mongoose');
var bcrypt = require('bcrypt');

var validateEmail = function(email) {
  var re = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
  return re.test(email)
};

var User = mongoose.Schema;
var UserSchema = new User({
    first_name: {
        type: String,
        required: [true, "this is for something else"],
        trim: true,
      },
    last_name: {
        type: String,
        required: true,
        trim: true
      },
  
    password: {
      type: String,
      required: true,
      minlength: 8,
      maxlength: 32,
      validate: {
        validator: function (value) {
          return /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,32}/.test(value);
        },
        message: "Password failed validation, you must have at least 1 number, uppercase and special character"
      }
    },

    email: {
      type: String,
      trim: true,
      lowercase: true,
      unique: true,
      required: 'Email address is required',
      validate: [validateEmail, 'Please fill a valid email address'],
      match: [/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/, 'Please fill a valid email address']
  },

    bdate: {
      type: Date,
      required: true,
    }

  }, {
      timestamps: {
        createdAt: 'created_at',
        updatedAt: 'updated_at'
      }
});

var User = mongoose.model('User', UserSchema);


// UserSchema.virtual('name.full').get(function () {
//   return this.name.first + " " + this.name.last;
//   // return `${ this.name.first } ${ this.name.last}`;
// });
