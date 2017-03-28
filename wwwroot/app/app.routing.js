"use strict";
var router_1 = require("@angular/router");
var home_component_1 = require('./components/home/home.component');
var quotes_component_1 = require('./components/quotes/quotes.component');
var claims_component_1 = require('./components/claims/claims.component');
var login_component_1 = require('./components/login/login.component');
var appRoutes = [{ path: "", component: home_component_1.HomeComponent },
    { path: "home", redirectTo: "" },
    { path: "quotes", component: quotes_component_1.QuotesComponent },
    { path: "claims", component: claims_component_1.ClaimsComponent },
    { path: "login", component: login_component_1.LoginComponent }];
exports.AppRoutingProviders = [];
exports.AppRouting = router_1.RouterModule.forRoot(appRoutes);
