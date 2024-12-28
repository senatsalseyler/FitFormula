import { initializeApp } from "https://www.gstatic.com/firebasejs/9.15.0/firebase-app.js";
import { getAuth } from "https://www.gstatic.com/firebasejs/9.15.0/firebase-auth.js";

const firebaseConfig = {
    apiKey: "AIzaSyBZdN7AuMkwZFSFwKWLy6QzVCx8vGMuK68",
    authDomain: "fitformula-27ac5.firebaseapp.com",
    databaseURL: "https://fitformula-27ac5-default-rtdb.firebaseio.com",
    projectId: "fitformula-27ac5",
    storageBucket: "fitformula-27ac5.firebasestorage.app",
    messagingSenderId: "511504403783",
    appId: "1:511504403783:web:b68aceed008d0627195062",
    measurementId: "G-LWXSJJKPQ9"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const auth = getAuth(app);

export { auth };
