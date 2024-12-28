document.addEventListener('DOMContentLoaded', () => {
    const auth = firebase.auth();

    // Login
    const loginButton = document.getElementById('loginButton');
    if (loginButton) {
        loginButton.addEventListener('click', async () => {
            const email = document.getElementById('email').value;
            const password = document.getElementById('password').value;

            try {
                const result = await auth.signInWithEmailAndPassword(email, password);
                const idToken = await result.user.getIdToken();

                // Verify token with server
                const response = await fetch('/Auth/VerifyToken', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({ token: idToken })
                });

                const data = await response.json();
                if (data.success) {
                    window.location.href = '/Home/Index';
                }
            } catch (error) {
                alert('Login failed: ' + error.message);
            }
        });
    }

    // Register
    const registerButton = document.getElementById('registerButton');
    if (registerButton) {
        registerButton.addEventListener('click', async () => {
            const email = document.getElementById('email').value;
            const password = document.getElementById('password').value;

            try {
                await auth.createUserWithEmailAndPassword(email, password);
                alert('Registration successful! Please login.');
                window.location.href = '/Auth/Login';
            } catch (error) {
                alert('Registration failed: ' + error.message);
            }
        });
    }
});