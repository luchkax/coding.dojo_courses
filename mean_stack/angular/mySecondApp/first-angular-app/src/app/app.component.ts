import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  data = [
          {email: 'mthurn@live.com', importance: true, subject: 'New Windows', content: 'Windows XI will launch in year 2100'}, 
          {email: 'rgarcia@optonline.net', importance: true, subject: 'Programming', content: 'Apple iPhone 20 launch in year 2100'},
          {email: 'abrahama@abc.com', importance: false, subject: 'Deploying', content: 'Dployment is very important in developing'},
          {email: 'umtiti@ine.net', importance: false, subject: 'FCBarcelona', content: 'Best defender in a club for a long time so far'},
          {email: 'royrob@scne.us', importance: true, subject: 'SCAM', content: 'Your credit card account...'}
  ];    
};
