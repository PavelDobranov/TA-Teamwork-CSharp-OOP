'use strict';

var mongoose = require('mongoose'),
  UserModel = require('../data/models/User');

function databaseOnError() {
  console.log('Database error: ' + err);
}

function databaseOnOpen(err) {
  if (err) {
    console.log('Database could not be opened: ' + err);
    return;
  }

  console.log('Database up and running...');
}

module.exports = function(config) {
  mongoose.connect(config.dbConnection);
  var db = mongoose.connection;

  db.on('error', databaseOnError);
  db.once('open', databaseOnOpen);

  UserModel.init();
};