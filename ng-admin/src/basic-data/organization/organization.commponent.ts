import { Component, Injector, AfterViewInit, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { _HttpClient } from '@delon/theme';
import { NzMessageService } from '../../../node_modules/ng-zorro-antd';

@Component({
    selector: 'organization',
    templateUrl: './organization.component.html',
    styleUrls: ['./organization.component.less'],
    animations: [appModuleAnimation()],
})
export class OrganizationComponent extends AppComponentBase {
    constructor(
        injector: Injector,
        public msg: NzMessageService,
    ) {
        super(injector);
    }
}