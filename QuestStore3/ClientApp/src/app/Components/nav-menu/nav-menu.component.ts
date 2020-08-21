import { Component, Inject, OnInit } from '@angular/core';
import { User } from '../user/user';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpService } from '../../services/http.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})


export class NavMenuComponent implements OnInit {
  isExpanded = false;
  loginForm: FormGroup;
  loginUser: User;
  private _httpClient: HttpClient;
  private _base: string;
  notLogged; admin; mentor; student: boolean;
  identity: string[];
  
  

  constructor(private https: HttpService, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
 
    this._httpClient = http;
    this._base = baseUrl;

  this.loginUser = {
      email: '',
      password: '',
    };
  }

    public logIn = () => {
    const route: string = 'api/account';
    this.https.getLogin(route, this.loginUser)
      .subscribe((result) => {
        window.location.reload()
      },
        (error) => {
          console.error(error);
        });
  }

  public identityInfo( list: string[]) {

    if (list[0] == "Admin") {
      this.admin = true;
    }
    else if (list[0] == "Mentor") {
      this.mentor = true;
    }
    else if (list[0] == "Student") {
      this.student = true;
    }
    else if (list[0] == null) {
      this.notLogged = true;
    }
  }

  ngOnInit() {
    let temp: string[];
    this._httpClient.get<string[]>(this._base + 'api/account').subscribe(result => {
      this.identity = result as string[];
      this.identityInfo(this.identity);
    });
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
  }

  logOut() {
    this._httpClient.options<boolean>(this._base + 'api/account').subscribe((result) => {
      window.location.reload();
    },
      (error) => {
        console.error(error);
      });   
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
