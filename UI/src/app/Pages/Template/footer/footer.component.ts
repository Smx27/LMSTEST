import { DOCUMENT } from '@angular/common';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {
  isMain = true;
  constructor(@Inject(DOCUMENT) private document: Document) { 
    if(this.document.location.pathname != "/")
      this.isMain = false;

  }
  ngOnInit(): void {
  }

}
