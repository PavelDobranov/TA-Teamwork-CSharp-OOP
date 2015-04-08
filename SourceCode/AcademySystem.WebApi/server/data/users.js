'use strict';

var User = require('mongoose').model('User');

function createUser(userData, callback) {
  User.create(userData, callback);
}

function updateUser(id, userData, callback) {
  User.findByIdAndUpdate(id, userData, callback);
}

function getAllUsers(callback) {
  User.find({}, callback);
}

module.exports = {
  create: createUser,
  update: updateUser,
  get: getAllUsers
};