import { Component, OnInit } from '@angular/core';
import { environment } from '../../environments/environment';
import { OpenIdConnectService } from '../shared/services/open-id-connect.service';
import { Router } from '@angular/router';

@Component({
    selector: 'hene-signin-oidc',
    templateUrl: './signin-oidc.component.html',
    styleUrls: ['./signin-oidc.component.scss']
})
export class SigninOidcComponent implements OnInit {

    constructor(private openIdConnectService: OpenIdConnectService, private router: Router) {}

    ngOnInit() {
        this.openIdConnectService.userLoaded$.subscribe((userLoaded) => {
            if (userLoaded) {
                this.router.navigate(['/']);
            } else {
                if (!environment.production) {
                    console.log('An error happened: user wasn\'t loaded.');
                }
            }
        });

        this.openIdConnectService.handleCallback();
    }
}