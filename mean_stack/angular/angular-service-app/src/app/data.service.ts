import { Injectable } from '@angular/core';

@Injectable()
export class DataService {
  numbers: 


  constructor() { }

  retrieveNumbers(): number[] {
    return this.numbers;
  }

  addNumber(num: number) {
    this.numbers.push(num);
  }
}
