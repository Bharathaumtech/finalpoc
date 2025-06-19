import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>

    <abp-internet-status></abp-internet-status>
  `,
})
export class AppComponent {}
