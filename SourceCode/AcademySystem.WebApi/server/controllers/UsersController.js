var encryption = require('../utilities/encryption'),
  users = require('../data/users');

function createUser(req, res, next) {
  var userData = req.body;
  userData.salt = encryption.generateRandomString();
  userData.hashPass = encryption.generateHashedPassword(userData.salt, userData.password);
  //userData.isAdmin = false;
  users.create(userData, function(err, user) {
    if (err) {
      console.log('User could not be added to database: ' + err);
      return res.send(err);
    }
    req.logIn(user, function(err) {
      if (err) {
        res.status(400);
        return res.send({
          reason: err.toString()
        });
      }
      res.send(user);
    });
  });
}

module.exports = {
  create: createUser,
  //update: updateUser,
  //get: getAllUsers
};