import { AuthService } from '@abp/ng.core';
import { Component, Inject } from '@angular/core';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated;
  }

  constructor(
    private authService: AuthService,
    @Inject(DOCUMENT) private document: Document // Injecting DOCUMENT properly
  ) {}

  login() {
    this.authService.navigateToLogin();
  }
}
