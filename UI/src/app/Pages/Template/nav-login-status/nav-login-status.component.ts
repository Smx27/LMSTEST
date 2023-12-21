import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-login-status',
  templateUrl: './nav-login-status.component.html',
  styleUrls: ['./nav-login-status.component.css']
})
export class NavLoginStatusComponent implements OnInit {
  userLoggedIn = true;
  constructor() { }

  ngOnInit(): void {
  }

}
