importScripts('https://www.gstatic.com/firebasejs/9.1.1/firebase-app.js');
importScripts('https://www.gstatic.com/firebasejs/9.1.1/firebase-messaging.js');

var config = {
    apiKey: "AIzaSyBb3EDILAPR8B-jsKzWSbI3OV63NOtP4JA",
    authDomain: "cmsweb-8cec4.firebaseapp.com",
    projectId: "cmsweb-8cec4",
    storageBucket: "cmsweb-8cec4.appspot.com",
    messagingSenderId: "864945036123",
    appId: "1:864945036123:web:11967a77660a3218f5d87e",
    measurementId: "G-VKZ8FB20BD"
};

firebase.initializeApp(config);

const messaging = firebase.messaging();

messaging.setBackgroundMessageHandler(function(payload) {
    //// Customize notification here
    var notificationTitle = 'My Titile';
    var notificationOptions = {
        body: payload.data.body
    };

    return self.registration.showNotification(notificationTitle,
        notificationOptions);
});