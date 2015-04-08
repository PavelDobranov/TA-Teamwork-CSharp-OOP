'use strict';

var express = require('express'),
  cookieParser = require('cookie-parser'),
  bodyParser = require('body-parser'),
  session = require('express-session'),
  passport = require('passport');

module.exports = function(server, config) {
  server.use(cookieParser());
  server.use(bodyParser.urlencoded({ extended: true }));
  server.use(bodyParser.json());
  server.use(session({
    secret: 'academysystem',
    resave: true,
    saveUninitialized: true
  }));
  server.use(passport.initialize());
  server.use(passport.session());
};