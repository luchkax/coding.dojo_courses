import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {


newarr =[];
chooseColor() {
  for (var k = 0; k < 7; k++){
    const randNum = (Math.floor(Math.random() * 6) ) + 1;
    if (randNum === 1) {
      this.newarr.push('red')
      }
    else if (randNum === 2) {
      this.newarr.push('blue')
      }
    else if (randNum === 3) {
      this.newarr.push('yellow')
      }
    else if (randNum === 4) {
      this.newarr.push('green')
      }
    else if (randNum === 5) {
      this.newarr.push('grey')
      }
    else if (randNum === 6) {
      this.newarr.push('purple')
      }
    }
  }
ngOnInit() {
    this.chooseColor();
    }
}

