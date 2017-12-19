import { Injectable } from '@angular/core';

@Injectable()
export class DataService {

  constructor() { }

  totalgold = 0;
  log: string[] = [];

  retrieveGold(){
    return this.totalgold;
  }

  retrieveLog(){
    return this.log;
  }

  addFarm(){
    let farm = Math.floor(Math.random() * 4 )+ 2;
    this.totalgold += farm;
    console.log(this.totalgold)
    this.log.push("You've earned " + farm + " gold at the Farm")
    return this.totalgold, this.log;
  }

  addCave(){
    let cave = Math.floor(Math.random() * 9 )+ 5;
    this.totalgold += cave;
    console.log(this.totalgold)
    this.log.push("You've earned " + cave + " gold at the Cave")    
    return this.totalgold, this.log;
  }

  addCasino(){
    let casino = Math.floor(Math.random() * 100 )+ 1;
    if(casino % 2 === 0){
      this.totalgold += casino;
      this.log.push("You've earned " + casino + " gold at the Casino")
      
    }
    else{
      this.totalgold -= casino; 
      this.log.push("You've lost " + casino + " gold at the Casino")
      
    }
    console.log(this.totalgold)
    return this.totalgold, this.log;
  }
  addHouse(){
    let house = Math.floor(Math.random() * 14 )+ 7;
    this.totalgold += house;
    console.log(this.totalgold)
    this.log.push("You've earned " + house + " gold at the House")    
    return this.totalgold, this.log;
  }


}
