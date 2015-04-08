'use strict';

var controllers = require('../controllers'),
  auth = require('./auth');

module.exports = function(server) {
  server.post('/users/register', controllers.users.create);
};