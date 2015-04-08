'use strict';

var crypto = require('crypto');

function generateRandomString() {
  return crypto.randomBytes(128).toString('base64');
}

function generateHashedPassword(salt, password) {
  //var hmac = crypto.createHmac('sha1', salt);
  //return hmac.update(password).digest('hex');

  return "12312312312312312321123"
}

module.exports = {
  generateRandomString: generateRandomString,
  generateHashedPassword: generateHashedPassword
};