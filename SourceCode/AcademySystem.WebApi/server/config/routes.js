var controllers = require('../controllers'),
  auth = require('./auth');

module.exports = function(server) {
  server.post('/users/register', controllers.users.create);

  // server.get('/api/users', controllers.users.get);
  // server.put('/api/users', controllers.users.update);
  // server.get('/partials/:partialName', function(req, res) {
    // res.render('../../public/app/partials/' + req.params.partialName);
  // });
  // server.post('/login', auth.login);
  // server.get('*', function(req, res) {
    // res.render('index');
  //});
};