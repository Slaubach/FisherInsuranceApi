"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require('@angular/core');
var platform_browser_1 = require('@angular/platform-browser');
var http_1 = require('@angular/http');
var router_1 = require('@angular/router');
var forms_1 = require('@angular/forms');
require('rxjs/Rx');
var app_component_1 = require('./app.component');
var home_component_1 = require('./components/home/home.component');
var navbar_component_1 = require('./components/navbar/navbar.component');
var login_component_1 = require('./components/login/login.component');
var claims_component_1 = require('./components/claims/claims.component');
var quotes_component_1 = require('./components/quotes/quotes.component');
var app_routing_1 = require('./app.routing');
var auth_http_1 = require("./auth.http");
var auth_service_1 = require("./auth.service");
var AppModule = (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                home_component_1.HomeComponent,
                navbar_component_1.NavBarComponent,
                login_component_1.LoginComponent,
                claims_component_1.ClaimsComponent,
                quotes_component_1.QuotesComponent
            ],
            imports: [
                platform_browser_1.BrowserModule,
                http_1.HttpModule,
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule,
                router_1.RouterModule,
                app_routing_1.AppRouting
            ],
            providers: [
                auth_service_1.AuthService,
                auth_http_1.AuthHttp
            ],
            bootstrap: [
                app_component_1.AppComponent
            ],
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;