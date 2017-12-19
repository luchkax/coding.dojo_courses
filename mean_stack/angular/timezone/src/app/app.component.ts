import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  time = new Date();
  last = null;
  clear: boolean = true;
  

  onButtonClick(timezone){
    this.time = new Date();
    this.clear = true;
    if (timezone === 'MST'){
      this.clear = true;
      this.time.setHours(this.time.getHours() -1);
    }
    else if (timezone === 'PST'){
      this.clear = true;
      this.time.setHours(this.time.getHours() -2);
      }
    else if (timezone === 'EST'){
      this.clear = true;      
      this.time.setHours(this.time.getHours() +1);
      }
    this.last = timezone;
  }

  clearAll(){
    this.clear = false;
    this.last = null;
  }
}
