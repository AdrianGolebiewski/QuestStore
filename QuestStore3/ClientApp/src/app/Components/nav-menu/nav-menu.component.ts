import { Component, Inject, OnInit } from '@angular/core';
import { User } from '../user/user';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpService } from '../../services/http.service';


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  loginForm: FormGroup;
  loginUser: User;
  @Inject('BASE_URL') baseUrl: string;
  userIdentity: any;
  error: any;


  constructor(private http: HttpService) {
    this.loginUser = {
      email: '',
      password: '',
    };
       
  }
  public logIn = () => {
    const route: string = 'account';
    this.http.getLogin(route, this.loginUser)
      .subscribe((userIdentity) => {
       alert("udało się all")
      },
        (error) => {
          console.error(this.error);
        });
  }


    ngOnInit() {
      this.initializeForm();
      
  }
  private initializeForm() {
    this.loginForm = new FormGroup({
      'email': new FormControl(null),
      'password': new FormControl(null),
    });
  }

  onSubmit() {
    this.loginUser = this.loginForm.value;
    this.logIn(); 


    //this.loginUser.email = this.loginForm.value.userLogin;
    //this.loginUser.password = this.loginForm.value.password;
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
