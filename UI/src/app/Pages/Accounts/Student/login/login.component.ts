import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/_models/user';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  user: User = {
    username: '',
    email: '',
    token: '',
    password: '',
    roles: []
  }
  constructor(private accountService: AccountService, private router: Router) { }

  ngOnInit(): void {
  }

  login() {
    if(this.user == null) return; 
    //Send some tost 
    this.accountService.login(this.user).subscribe({
      next: ()=> this.router.navigateByUrl('/student/dashbord')
    })
  }
}
