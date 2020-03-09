import { Component } from '@angular/core';

// this file is redsponsible to provide the view to our app.

@Component({ // this is a decorator.
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DatingApp-SPA';
}
