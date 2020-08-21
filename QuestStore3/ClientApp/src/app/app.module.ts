import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';  

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { CounterComponent } from './components/counter/counter.component';
import { FetchDataComponent } from './components/fetch-data/fetch-data.component';
import { OverviewComponent } from './components/quest/overview/overview.component';
import { AddComponent } from './components/quest/add/add.component';
import { GetBonusComponent } from './Components/bonus/get-bonus/get-bonus.component';
import { GetUserComponent } from './Components/user/get-user/get-user.component';
import { RegistrationComponent } from './Components/home/registration/registration.component';
import { GetMyStudentsComponent } from './Components/mentor/get-my-students/get-my-students.component';
import { GetMyGroupsComponent } from './Components/mentor/get-my-groups/get-my-groups.component';
import { AddGroupComponent } from './Components/group/add-group/add-group.component';
import { DetailsGroupComponent } from './Components/group/details-group/details-group.component';
import { FooterComponent } from './Components/footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    OverviewComponent,
    AddComponent,
    GetBonusComponent,
    GetUserComponent,
    RegistrationComponent,
    GetMyStudentsComponent,
    GetMyGroupsComponent,
    AddGroupComponent,
    DetailsGroupComponent,
    FooterComponent,

    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'overview', component: OverviewComponent },
      { path: 'get-bonus', component: GetBonusComponent },
      { path: 'get-user', component: GetUserComponent },
      { path: 'registration', component: RegistrationComponent },
      { path: 'get-my-students', component: GetMyStudentsComponent },
      { path: 'get-my-groups', component: GetMyGroupsComponent },
      { path: 'add-group', component: AddGroupComponent },

    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
