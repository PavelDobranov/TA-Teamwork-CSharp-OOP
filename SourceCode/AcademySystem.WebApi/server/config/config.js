'use strict';

var path = require('path');

var rootPath = path.normalize(__dirname + '/../../');

module.exports = {
  development: {
    port: 3030,
    dbConnection: 'mongodb://admin:devacademysystem@ds029911.mongolab.com:29911/devacademysystem',
    rootPath: rootPath
  },
  production: {
    port: process.env.PORT || 3030,
    dbConnection: 'mongodb://admin:prodacademysystem@ds039231.mongolab.com:39231/prodacademysystem',
    rootPath: rootPath
  }
};