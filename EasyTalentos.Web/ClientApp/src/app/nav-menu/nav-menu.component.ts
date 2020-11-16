import { Component, Input, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit{
  
  isExpanded = false;
  isEnglish: boolean = false;


  @Output('langChange') langChangeOutPut = new EventEmitter();

  ngOnInit(): void {
    
  }

  public langChange() {

    this.isEnglish = !this.isEnglish;

    if (this.isEnglish) this.langChangeOutPut.emit('en');
    else this.langChangeOutPut.emit('pt-br');
  }


  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
