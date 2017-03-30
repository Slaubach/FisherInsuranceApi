"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require('@angular/core');
var forms_1 = require('@angular/forms');
var LoginComponent = (function () {
    function LoginComponent(fb, router, authService) {
        this.fb = fb;
        this.router = router;
        this.authService = authService;
        this.title = "Login";
        this.loginForm = null;
        if (this.authService.isLoggedIn()) {
            this.router.navigate([""]);
        }
        this.loginForm = fb.group({
            username: ["", forms_1.Validators.required],
            password: ["", forms_1.Validators.required]
        });
    }
    LoginComponent.prototype.performLogin = function (e) {
        var _this = this;
        e.preventDefault();
        var username = this.loginForm.value.username;
        var password = this.loginForm.value.password;
        this.authService.login(username, password)
            .subscribe(function (data) {
            _this.loginError = false;
            var auth = _this.authService.getAuth();
            alert("Our Token is: " + auth.access_token);
            _this.router.navigate([""]);
        }, function (err) {
            console.log(err);
            // login failure                
            _this.loginError = true;
        });
    };
    LoginComponent = __decorate([
        core_1.Component({
            selector: 'login',
            templateUrl: './app/components/login/login.component.html',
            styleUrls: ['./app/components/login/login.component.css']
        })
    ], LoginComponent);
    return LoginComponent;
}());
exports.LoginComponent = LoginComponent;
