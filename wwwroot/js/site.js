// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById('menu-toggle').addEventListener('click', function () {
    var menu = document.getElementById('menu'); if (menu.style.left === '-200px')
    { menu.style.left = '0'; } else { menu.style.left = '-200px'; }
});