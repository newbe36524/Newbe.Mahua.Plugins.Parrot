var express = require('express');
var bodyParser = require('body-parser')
var http = require('http');
var app = express();
var jsonParser = bodyParser.json()

function sendRequest(qq, msg) {
    var postData = {
        "qqid": qq,
        "msg": msg
    };
    var req = http.request({
        host: '127.0.0.1',
        port: '36524',
        method: 'POST',
        path: '/api/v1/Cqp/CQ_sendPrivateMsg',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    req.write(JSON.stringify(postData));
    req.end();
}

app.get('/', function (req, res) {
    res.send('This is demo server for Newbe.Mahua.Plugins.Parrot in javascript');
});

app.post('/api/ReceiveMahuaOutput', jsonParser, function (req, res) {
    var data = req.body;
    if (data.TypeCode === 'ProcessPrivateMessage' &&
        data.SubType === 11) {
        sendRequest(data.FromQQ, data.Msg);
    }
});

var server = app.listen(65321, function () {

    var host = server.address().address
    var port = server.address().port

    console.log("server started at http://%s:%s", host, port)

});