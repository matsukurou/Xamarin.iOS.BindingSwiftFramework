//
//  FrameworkSwift.swift
//  FrameworkSwift
//
//  Created by matsusaki-local on 2015/12/04.
//  Copyright © 2015年 Kazutaka Matsusaki. All rights reserved.
//

public class FrameworkSwift : NSObject {
    
    @objc public class func start(){
        NSLog("Hello, world")
        print("MyFrameworkSwift starting...");
    }
    
    public func startPrint(){
        print("MyFrameworkSwift star printing...");
    }
}
