import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { ChannelCreateComponent } from './channel-create/channel-create.component';
import { ChannelOptionsComponent } from './channel-options/channel-options.component';
import { ChatboxComponent } from './chatbox/chatbox.component';
import { EditComponent } from './edit/edit.component';
import { LandingComponent } from './landing/landing.component';
import { LoginComponent } from './login/login.component';
import { MainComponent } from './main/main.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ProfileComponent } from './profile/profile.component';
import { RegComponent } from './reg/reg.component';
import { UserDetailsComponent } from './user-details/user-details.component';


@NgModule({
  declarations: [
    AppComponent,
    ChannelCreateComponent,
    ChannelOptionsComponent,
    ChatboxComponent,
    EditComponent,
    LandingComponent,
    LoginComponent,
    MainComponent,
    NavbarComponent,
    ProfileComponent,
    RegComponent,
    UserDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
