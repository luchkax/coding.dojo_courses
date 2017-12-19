import { Component } from '@angular/core';
import { User } from './user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
 
  user = new User();
  users = [];
  msg1:boolean = false;
  tempUser = {}

  onSubmit(){
    this.users.push(this.user);
    this.msg1 = true;
    this.tempUser = this.user
    this.user = new User();
    
    
  }
}
