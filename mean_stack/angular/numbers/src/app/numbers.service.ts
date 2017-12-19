import { Injectable } from '@angular/core';


@Injectable()
export class NumbersService {

  numbers1: number[] = [];
  numbers2: number[] = [];
  generalSum: number[] = [];
  
  constructor() { }

  retrieveNumbers1(): number[]{
    return this.numbers1;
  }  

  retrieveNumbers2(): number[]{
    return this.numbers2;
  }  

  retrieveSum(): number[]{
    return this.generalSum;
  }

  addNumber1(){
    let num = Math.floor((Math.random() * 10) + 1);
    this.numbers1.push(num);
    return this.numbers1;
  }
  addNumber2(){
    let num = Math.floor((Math.random() * 10) + 1);
    this.numbers2.push(num);
    return this.numbers2;
  }
  different(){
    let sum1 = 0;
    let sum2 = 0;

    for (var i of this.numbers1) {
      sum1 += i;
    };
    // console.log(sum1);

    for (var j of this.numbers2) {
      sum2 += j;
    }
    // console.log(sum2);
    var genSum = sum1-sum2;
    this.generalSum.push(genSum)
    console.log(this.generalSum)

    return this.generalSum;
  }

}



